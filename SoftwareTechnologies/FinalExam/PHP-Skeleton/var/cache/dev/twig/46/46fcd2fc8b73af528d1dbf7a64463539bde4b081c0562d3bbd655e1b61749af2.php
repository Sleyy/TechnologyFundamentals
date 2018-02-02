<?php

/* project/edit.html.twig */
class __TwigTemplate_1aebb8a23da8eb793c9210291362072b2051dec512cd4a9ad045b9bd76256b73 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("base.html.twig", "project/edit.html.twig", 1);
        $this->blocks = array(
            'main' => array($this, 'block_main'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "base.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_b43a6503cf11d1e32e1f70a5f49f1685383d06f303ef930039e5d4f28fe73cae = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_b43a6503cf11d1e32e1f70a5f49f1685383d06f303ef930039e5d4f28fe73cae->enter($__internal_b43a6503cf11d1e32e1f70a5f49f1685383d06f303ef930039e5d4f28fe73cae_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "project/edit.html.twig"));

        $__internal_10dc3a63a4a2644f5caed44e17c25a203ddd3fe3bf147f5fa5dba16da7ca1b9a = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_10dc3a63a4a2644f5caed44e17c25a203ddd3fe3bf147f5fa5dba16da7ca1b9a->enter($__internal_10dc3a63a4a2644f5caed44e17c25a203ddd3fe3bf147f5fa5dba16da7ca1b9a_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "project/edit.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_b43a6503cf11d1e32e1f70a5f49f1685383d06f303ef930039e5d4f28fe73cae->leave($__internal_b43a6503cf11d1e32e1f70a5f49f1685383d06f303ef930039e5d4f28fe73cae_prof);

        
        $__internal_10dc3a63a4a2644f5caed44e17c25a203ddd3fe3bf147f5fa5dba16da7ca1b9a->leave($__internal_10dc3a63a4a2644f5caed44e17c25a203ddd3fe3bf147f5fa5dba16da7ca1b9a_prof);

    }

    // line 3
    public function block_main($context, array $blocks = array())
    {
        $__internal_40b0d07dcccef28757ffeb92d0b0bc1737cb148353bc26ccbb7fe6296e17b398 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_40b0d07dcccef28757ffeb92d0b0bc1737cb148353bc26ccbb7fe6296e17b398->enter($__internal_40b0d07dcccef28757ffeb92d0b0bc1737cb148353bc26ccbb7fe6296e17b398_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        $__internal_59c003c755d3c921d121590d97e0d353001c08b181f5a0b8ec5274c8a2da0560 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_59c003c755d3c921d121590d97e0d353001c08b181f5a0b8ec5274c8a2da0560->enter($__internal_59c003c755d3c921d121590d97e0d353001c08b181f5a0b8ec5274c8a2da0560_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        // line 4
        echo "<div class=\"wrapper\">
    <form class=\"project-create\" method=\"post\">
        <div class=\"create-header\">
            Delete Project
        </div>
        <div class=\"create-title\">
            <div class=\"create-title-label\">Title</div>
            <input class=\"create-title-content\" name=\"project[title]\" value=\"";
        // line 11
        echo twig_escape_filter($this->env, $this->getAttribute(($context["project"] ?? $this->getContext($context, "project")), "title", array()), "html", null, true);
        echo "\" />
        </div>
        <div class=\"create-description\">
            <div class=\"create-description-label\">Description</div>
            <textarea rows=\"3\" class=\"create-description-content\" name=\"project[description]\">";
        // line 15
        echo twig_escape_filter($this->env, $this->getAttribute(($context["project"] ?? $this->getContext($context, "project")), "description", array()), "html", null, true);
        echo "</textarea>
        </div>
        <div class=\"create-budget\">
            <div class=\"create-budget-label\">Budget</div>
            <input type=\"number\" min=\"0\" class=\"create-budget-content\" name=\"project[budget]\" value=\"";
        // line 19
        echo twig_escape_filter($this->env, $this->getAttribute(($context["project"] ?? $this->getContext($context, "project")), "budget", array()), "html", null, true);
        echo "\" />
        </div>
        <div class=\"create-button-holder\">
            <button type=\"submit\" class=\"submit-button\">Edit Project</button>
            <a type=\"button\" href=\"/\" class=\"back-button\">Back</a>
        </div>

        ";
        // line 26
        echo $this->env->getRuntime('Symfony\Bridge\Twig\Form\TwigRenderer')->searchAndRenderBlock($this->getAttribute(($context["form"] ?? $this->getContext($context, "form")), "_token", array()), 'row');
        echo "
    </form>
</div>
";
        
        $__internal_59c003c755d3c921d121590d97e0d353001c08b181f5a0b8ec5274c8a2da0560->leave($__internal_59c003c755d3c921d121590d97e0d353001c08b181f5a0b8ec5274c8a2da0560_prof);

        
        $__internal_40b0d07dcccef28757ffeb92d0b0bc1737cb148353bc26ccbb7fe6296e17b398->leave($__internal_40b0d07dcccef28757ffeb92d0b0bc1737cb148353bc26ccbb7fe6296e17b398_prof);

    }

    public function getTemplateName()
    {
        return "project/edit.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  82 => 26,  72 => 19,  65 => 15,  58 => 11,  49 => 4,  40 => 3,  11 => 1,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("{% extends \"base.html.twig\" %}

{% block main %}
<div class=\"wrapper\">
    <form class=\"project-create\" method=\"post\">
        <div class=\"create-header\">
            Delete Project
        </div>
        <div class=\"create-title\">
            <div class=\"create-title-label\">Title</div>
            <input class=\"create-title-content\" name=\"project[title]\" value=\"{{ project.title }}\" />
        </div>
        <div class=\"create-description\">
            <div class=\"create-description-label\">Description</div>
            <textarea rows=\"3\" class=\"create-description-content\" name=\"project[description]\">{{ project.description }}</textarea>
        </div>
        <div class=\"create-budget\">
            <div class=\"create-budget-label\">Budget</div>
            <input type=\"number\" min=\"0\" class=\"create-budget-content\" name=\"project[budget]\" value=\"{{ project.budget }}\" />
        </div>
        <div class=\"create-button-holder\">
            <button type=\"submit\" class=\"submit-button\">Edit Project</button>
            <a type=\"button\" href=\"/\" class=\"back-button\">Back</a>
        </div>

        {{ form_row(form._token) }}
    </form>
</div>
{% endblock %}

", "project/edit.html.twig", "C:\\Projects\\PHP-Skeleton\\app\\Resources\\views\\project\\edit.html.twig");
    }
}
